namespace Code;

public class Spiral 
{
    public IList<int> SpiralOrder(int[][] matrix) 
    {
        var xMin = 0;
        var xMax = matrix[0].Length - 1;

        var yMin = 0;
        var yMax = matrix.Length - 1;

        var result = new List<int>();

        while (yMin <= yMax && xMin <= xMax)
        {
            for (var x = xMin; x <= xMax; x++)
            {
                result.Add(matrix[yMin][x]);
            }
            yMin += 1;

            for (var y = yMin; y <= yMax; y++)
            {
                result.Add(matrix[y][xMax]);
            }
            xMax -= 1;

            if(yMin > yMax || xMin > xMax)
            {
                break;
            }

            for (var x = xMax; x >= xMin; x--)
            {
                result.Add(matrix[yMax][x]);
            }
            yMax -= 1;


            for (var y = yMax; y >= yMin; y--)
            {
                result.Add(matrix[y][xMin]);
            }
            xMin += 1;
        }

        return result;
    }
}