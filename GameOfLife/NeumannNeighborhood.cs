using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    static class NeumannNeighborhood
    {
        static public int returnNextStep(int [,] matrix,int cellInRow, int cellInColumn, int yCellIndex, int xCellIndex,string condition)
        { 
            int leftIndex = BoundaryConditions.getLeftIndex(cellInRow, xCellIndex, condition);
            int rightIndex = BoundaryConditions.getRightIndex(cellInRow, xCellIndex, condition);
            int upperIndex = BoundaryConditions.getUpperIndex(cellInColumn, yCellIndex, condition);
            int lowerIndex = BoundaryConditions.getLowerIndex(cellInColumn, yCellIndex, condition);

            if (leftIndex < 0) leftIndex = 0;
            if (rightIndex < 0) rightIndex = 0;
            if (upperIndex < 0) upperIndex = 0;
            if (lowerIndex < 0) lowerIndex = 0;


            Dictionary<int, int> neighbours = new Dictionary<int, int> ();
            logic.addToMap(ref neighbours, matrix[upperIndex, xCellIndex]);
            logic.addToMap(ref neighbours, matrix[yCellIndex, leftIndex]);
            logic.addToMap(ref neighbours, matrix[yCellIndex, rightIndex]);
            logic.addToMap(ref neighbours, matrix[lowerIndex, xCellIndex]);

            int mostCommonNeighboor = logic.getBiggestAmount(neighbours);
            return mostCommonNeighboor;
        }
    }
}
