namespace Code;

public class Pascal {
    public IList<IList<int>> Generate(int numRows) 
    {
        var resultSet = new List<IList<int>>();

        for(var row = 1; row <= numRows; row++)
        {
            var rowValues = new List<int>();
            var coeffcient = 1;
            for(var rowPos = 1; rowPos <= row; rowPos++)
            {
                rowValues.Add(coeffcient);
                coeffcient = coeffcient * (row - rowPos) / rowPos;
            }
            resultSet.Add(rowValues);
        }

        return resultSet;
    }
}