public class FileOutput
{
    StreamWriter output = null;
    private string _fileName;

    public FileOutput(string fileName)
    {
        this._fileName = fileName;
        try
        {
            output = new StreamWriter(fileName);
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("File Open Error: " + fileName + " " + e);
        }
    }

    public void FileWrite(string line)
    {
        try
        {
            output.Write(line + "\n");
        }
        catch(Exception e)
        {
            Console.WriteLine("File Write Error: " + _fileName + " " + e);
        }
    }

    public void FileClose() {
        if (output != null) {
            try {
                output.Close();
            } catch (IOException e) {
                Console.WriteLine(e.StackTrace);
            }
        }

    }
}