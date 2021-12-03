using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class HexagonalNeighborhood
    {
        static public int returnNextStep(int[,] matrix, int cellInRow, int cellInColumn, int yCellIndex, int xCellIndex, string condition, string sideCase)
        {
            int leftIndex = BoundaryConditions.getLeftIndex(cellInRow, xCellIndex,condition);
            int rightIndex = BoundaryConditions.getRightIndex(cellInRow, xCellIndex,condition);
            int upperIndex = BoundaryConditions.getUpperIndex(cellInColumn, yCellIndex,condition);
            int lowerIndex = BoundaryConditions.getLowerIndex(cellInColumn, yCellIndex,condition);


            if (leftIndex < 0) leftIndex = 0;
            if (rightIndex < 0) rightIndex = 0;
            if (upperIndex < 0) upperIndex = 0;
            if (lowerIndex < 0) lowerIndex = 0;


            Dictionary<int, int> neighbours = new Dictionary<int, int>();
            switch (sideCase)
            {
                case "z lewej strony":
                    neighbours = singleCase(matrix, xCellIndex, yCellIndex, rightIndex, leftIndex, upperIndex, lowerIndex);
                    break;
                case "z prawej strony":
                    neighbours = singleCase(matrix, xCellIndex, yCellIndex, leftIndex, rightIndex, upperIndex, lowerIndex);
                    break;
                default:
                    neighbours.Clear();
                    break;
            }


            int mostCommonNeighboor = logic.getBiggestAmount(neighbours);
            return mostCommonNeighboor;

        }

        static Dictionary<int, int> singleCase(int[,] matrix, int x, int y, int side1Index, int side2Index, int upperIndex, int lowerIndex)
        {
            Dictionary<int, int> neighbours = new Dictionary<int, int>();
            logic.addToMap(ref neighbours, matrix[upperIndex, x]);
            logic.addToMap(ref neighbours, matrix[upperIndex, side1Index]);
            logic.addToMap(ref neighbours, matrix[y, side1Index]);
            logic.addToMap(ref neighbours, matrix[y, side2Index]);
            logic.addToMap(ref neighbours, matrix[lowerIndex, x]);
            logic.addToMap(ref neighbours, matrix[lowerIndex, side2Index]);
            return neighbours;
        }
    }
    
}

