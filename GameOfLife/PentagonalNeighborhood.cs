using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class PentagonalNeighborhood
    {
        static public int returnNextStep(int[,] matrix, int cellInRow, int cellInColumn, int yCellIndex, int xCellIndex, string condition, int randomCase)
        {
            int leftIndex = BoundaryConditions.getLeftIndex(cellInRow, xCellIndex, condition);
            int rightIndex = BoundaryConditions.getRightIndex(cellInRow, xCellIndex, condition);
            int upperIndex = BoundaryConditions.getUpperIndex(cellInColumn, yCellIndex, condition);
            int lowerIndex = BoundaryConditions.getLowerIndex(cellInColumn, yCellIndex, condition);


            if (leftIndex < 0) leftIndex = 0;
            if (rightIndex < 0) rightIndex = 0;
            if (upperIndex < 0) upperIndex = 0;
            if (lowerIndex < 0) lowerIndex = 0;

            Dictionary<int, int> neighbours = new Dictionary<int, int>();
            switch (randomCase)
            {
                case 0:
                    neighbours = verticalCase(matrix, xCellIndex, yCellIndex, leftIndex, rightIndex, upperIndex);
                    break;
                case 1:
                    neighbours = verticalCase(matrix, xCellIndex, yCellIndex, leftIndex, rightIndex, lowerIndex);
                    break;
                case 2:
                    neighbours = horizontalCase(matrix, xCellIndex, yCellIndex, upperIndex, lowerIndex, rightIndex);
                    break;
                case 3:
                    neighbours = horizontalCase(matrix, xCellIndex, yCellIndex, upperIndex, lowerIndex, leftIndex);
                    break;
                default:
                    neighbours.Clear();
                    break;
            }

            int mostCommonNeighboor = logic.getBiggestAmount(neighbours);
            return mostCommonNeighboor;

        }
        static Dictionary<int, int> verticalCase(int[,] matrix, int x, int y, int leftIndex, int rightIndex, int verticalIndex)
        {
            Dictionary<int, int> neighbours = new Dictionary<int, int>();
            logic.addToMap(ref neighbours, matrix[verticalIndex, x]);
            logic.addToMap(ref neighbours, matrix[verticalIndex, leftIndex]);
            logic.addToMap(ref neighbours, matrix[verticalIndex, rightIndex]);
            logic.addToMap(ref neighbours, matrix[y, leftIndex]);
            logic.addToMap(ref neighbours, matrix[y, rightIndex]);
            return neighbours;
        }

        static Dictionary<int, int> horizontalCase(int[,] matrix, int x, int y, int upperIndex, int lowerIndex, int horizontalIndex)
        {
            Dictionary<int, int> neighbours = new Dictionary<int, int>();
            logic.addToMap(ref neighbours, matrix[upperIndex, x]);
            logic.addToMap(ref neighbours, matrix[upperIndex, horizontalIndex]);
            logic.addToMap(ref neighbours, matrix[y, horizontalIndex]);
            logic.addToMap(ref neighbours, matrix[lowerIndex, x]);
            logic.addToMap(ref neighbours, matrix[lowerIndex, horizontalIndex]);
            return neighbours;
        }
    }
}
