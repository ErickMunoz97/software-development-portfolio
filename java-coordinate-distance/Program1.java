import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.List;
import java.util.Locale;
import java.util.stream.Stream;

/** Pairwise Euclidean distance between points read from .txt files. */
public class Program1 {
    private static class Coordinate {
        final double x;
        final double y;
        Coordinate(double x, double y) { this.x = x; this.y = y; }
    }

    static List<Coordinate> readCoordinates(Path path) throws IOException {
        List<Coordinate> coordinates = new ArrayList<>();
        int lineNo = 0;
        for (String line : Files.readAllLines(path)) {
            lineNo++;
            if (line.isBlank()) continue;
            String[] parts = line.trim().split("\\s+");
            if (parts.length != 2) {
                System.err.printf("%s:%d: expected two numeric coordinates%n", path.getFileName(), lineNo);
                continue;
            }
            try {
                double x = Double.parseDouble(parts[0]);
                double y = Double.parseDouble(parts[1]);
                if (!Double.isFinite(x) || !Double.isFinite(y)) throw new NumberFormatException();
                coordinates.add(new Coordinate(x, y));
            } catch (NumberFormatException ex) {
                System.err.printf("%s:%d: invalid number%n", path.getFileName(), lineNo);
            }
        }
        return coordinates;
    }

    static double distance(Coordinate a, Coordinate b) {
        return Math.hypot(a.x - b.x, a.y - b.y);
    }

    public static void main(String[] args) throws IOException {
        Path dir = Path.of(args.length > 0 ? args[0] : "sample-data");
        if (!Files.isDirectory(dir)) {
            System.err.println("Directory not found: " + dir);
            System.exit(1);
        }
        try (Stream<Path> paths = Files.list(dir)) {
            List<Path> files = paths.filter(Files::isRegularFile)
                    .filter(p -> p.getFileName().toString().toLowerCase(Locale.ROOT).endsWith(".txt"))
                    .sorted(Comparator.comparing(Path::toString)).toList();
            if (files.isEmpty()) System.out.println("No .txt files found.");
            for (Path file : files) {
                List<Coordinate> points = readCoordinates(file);
                System.out.printf("File: %s (%d valid points)%n", file.getFileName(), points.size());
                for (int i = 0; i < points.size(); i++) {
                    for (int j = i + 1; j < points.size(); j++) {
                        System.out.printf(Locale.US, "  (%.2f, %.2f) -> (%.2f, %.2f): %.3f%n",
                                points.get(i).x, points.get(i).y, points.get(j).x, points.get(j).y,
                                distance(points.get(i), points.get(j)));
                    }
                }
            }
        }
    }
}
