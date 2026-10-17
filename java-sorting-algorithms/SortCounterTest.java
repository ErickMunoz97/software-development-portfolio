import java.util.Arrays;
import java.util.Random;

public class SortCounterTest {
    public static void main(String[] args) {
        for (int n = 0; n <= 100; n++) {
            for (int seed = 0; seed < 10; seed++) {
                int[] original = new Random(n * 101L + seed).ints(n, -5, 6).toArray();
                int[] expected = original.clone(); Arrays.sort(expected);
                for (String alg : new String[]{"insertion", "bubble", "merge", "heap", "quick"}) {
                    int[] a = original.clone(); SortCounter.Counter c = new SortCounter.Counter();
                    switch (alg) {
                        case "insertion" -> SortCounter.insertion(a, c);
                        case "bubble" -> SortCounter.bubble(a, c);
                        case "merge" -> SortCounter.mergeSort(a, 0, a.length, new int[a.length], c);
                        case "heap" -> SortCounter.heapSort(a, c);
                        case "quick" -> SortCounter.quickSort(a, 0, a.length - 1, c);
                    }
                    if (!Arrays.equals(a, expected)) throw new AssertionError(alg + " n=" + n + " seed=" + seed);
                }
            }
        }
        System.out.println("PASS: 5050 algorithm checks (101 sizes x 10 seeds x 5 algorithms)");
    }
}
