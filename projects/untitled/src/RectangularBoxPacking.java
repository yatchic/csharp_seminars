import java.util.*;

public class RectangularBoxPacking {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Введите количество коробок: ");
        int numBoxes = scanner.nextInt();

        List<Double> boxWidths = new ArrayList<>();
        List<Double> boxHeights = new ArrayList<>();

        System.out.println("Введите ширину и высоту каждой коробки (одна строка - ширина и высота через пробел):");
        for (int i = 0; i < numBoxes; i++) {
            double width = scanner.nextDouble();
            double height = scanner.nextDouble();
            boxWidths.add(width);
            boxHeights.add(height);
        }

        List<Integer> packingOrder = findOptimalPackingOrder(boxWidths, boxHeights);
        System.out.println("Оптимальная упаковка:");
        for (int index : packingOrder) {
            System.out.println("Коробка " + (index + 1) + ": Ширина " + boxWidths.get(index) + ", Высота " + boxHeights.get(index));
        }
    }

    private static List<Integer> findOptimalPackingOrder(List<Double> widths, List<Double> heights) {
        List<Integer> packingOrder = new ArrayList<>();
        int numBoxes = widths.size();
        boolean[] visited = new boolean[numBoxes];

        // Находим оптимальную упаковку с помощью жадного алгоритма
        for (int i = 0; i < numBoxes; i++) {
            int bestIndex = -1;
            double bestArea = Double.MAX_VALUE;

            for (int j = 0; j < numBoxes; j++) {
                if (!visited[j]) {
                    double area = widths.get(j) * heights.get(j);
                    if (area < bestArea) {
                        bestArea = area;
                        bestIndex = j;
                    }
                }
            }

            visited[bestIndex] = true;
            packingOrder.add(bestIndex);
        }

        return packingOrder;
    }
}