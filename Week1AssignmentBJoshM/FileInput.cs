public class FileInput 
{
    private StreamReader input = null;

    private string _fileName;

    public FileInput(string fileName)
    {
        this._fileName = fileName;
        try{
            input = new StreamReader(fileName);
        } 
        catch (Exception e)
        {
            Console.WriteLine("File Open Error: " + fileName + " " + e);
        }
    }

    public void FileRead()
    {
        string line;
        try{
            while ((line = input.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception e){
            Console.WriteLine("File Write Error: " + _fileName + " " + e);
        }
    }

    public string FileReadLine() {
        try {
            string line = input.ReadLine();
            return line;
        } catch (Exception e) {
            Console.WriteLine("File Write Error: " + _fileName + " " + e);
            return null;
        }
    }

    public void FileClose() {
        if (input != null) {
            try {
                input.Close();
            } catch (IOException e) {
                Console.WriteLine(e.StackTrace);
            }
        }

    }
}