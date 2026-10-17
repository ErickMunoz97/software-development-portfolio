import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.Arrays;
import java.util.Random;

/** Reproducible sorting-algorithm comparisons. Counters represent key comparisons. */
public class SortCounter {
    static class Counter { long comparisons; }

    public static void main(String[] args) throws IOException {
        int[] sizes = {5, 10, 20, 40, 80, 100};
        StringBuilder csv = new StringBuilder("algorithm,size,key_comparisons,sorted\n");
        for (int size : sizes) {
            int[] source = new Random(2026L + size).ints(size, 0, 1000).toArray();
            for (String algorithm : new String[]{"insertion", "bubble", "merge", "heap", "quick"}) {
                int[] data = source.clone();
                Counter c = new Counter();
                switch (algorithm) {
                    case "insertion" -> insertion(data, c);
                    case "bubble" -> bubble(data, c);
                    case "merge" -> mergeSort(data, 0, data.length, new int[data.length], c);
                    case "heap" -> heapSort(data, c);
                    case "quick" -> quickSort(data, 0, data.length - 1, c);
                    default -> throw new IllegalStateException(algorithm);
                }
                boolean sorted = isSorted(data);
                if (!sorted) throw new IllegalStateException(algorithm + " failed for size " + size);
                csv.append(algorithm).append(',').append(size).append(',')
                   .append(c.comparisons).append(',').append(sorted).append('\n');
            }
        }
        Path destination = Path.of(args.length > 0 ? args[0] : "results.csv");
        Files.writeString(destination, csv);
        System.out.println("Wrote " + destination + " (five algorithms x six sizes)");
    }

    static boolean isSorted(int[] a) {
        for (int i = 1; i < a.length; i++) if (a[i - 1] > a[i]) return false;
        return true;
    }
    static void insertion(int[] a, Counter c) {
        for (int i = 1; i < a.length; i++) {
            int key = a[i], j = i - 1;
            while (j >= 0) {
                c.comparisons++;
                if (a[j] <= key) break;
                a[j + 1] = a[j--];
            }
            a[j + 1] = key;
        }
    }
    static void bubble(int[] a, Counter c) {
        for (int end = a.length - 1; end > 0; end--) {
            boolean moved = false;
            for (int i = 0; i < end; i++) {
                c.comparisons++;
                if (a[i] > a[i + 1]) {
                    int tmp = a[i]; a[i] = a[i + 1]; a[i + 1] = tmp;
                    moved = true;
                }
            }
            if (!moved) break;
        }
    }
    static void mergeSort(int[] a, int lo, int hi, int[] tmp, Counter c) {
        if (hi - lo <= 1) return;
        int mid = (lo + hi) / 2;
        mergeSort(a, lo, mid, tmp, c); mergeSort(a, mid, hi, tmp, c);
        int i = lo, j = mid, k = lo;
        while (i < mid && j < hi) {
            c.comparisons++;
            tmp[k++] = (a[i] <= a[j]) ? a[i++] : a[j++];
        }
        while (i < mid) tmp[k++] = a[i++];
        while (j < hi) tmp[k++] = a[j++];
        System.arraycopy(tmp, lo, a, lo, hi - lo);
    }
    static void heapSort(int[] a, Counter c) {
        for (int i = a.length / 2 - 1; i >= 0; i--) heapify(a, a.length, i, c);
        for (int end = a.length - 1; end > 0; end--) {
            int tmp = a[0]; a[0] = a[end]; a[end] = tmp;
            heapify(a, end, 0, c);
        }
    }
    static void heapify(int[] a, int size, int root, Counter c) {
        while (true) {
            int largest = root, left = root * 2 + 1, right = left + 1;
            if (left < size) { c.comparisons++; if (a[left] > a[largest]) largest = left; }
            if (right < size) { c.comparisons++; if (a[right] > a[largest]) largest = right; }
            if (largest == root) return;
            int tmp = a[root]; a[root] = a[largest]; a[largest] = tmp;
            root = largest;
        }
    }
    static void quickSort(int[] a, int lo, int hi, Counter c) {
        if (lo >= hi) return;
        int pivot = a[hi], boundary = lo;
        for (int j = lo; j < hi; j++) {
            c.comparisons++;
            if (a[j] <= pivot) {
                int tmp = a[boundary]; a[boundary] = a[j]; a[j] = tmp;
                boundary++;
            }
        }
        int tmp = a[boundary]; a[boundary] = a[hi]; a[hi] = tmp;
        quickSort(a, lo, boundary - 1, c);
        quickSort(a, boundary + 1, hi, c);
    }
}
