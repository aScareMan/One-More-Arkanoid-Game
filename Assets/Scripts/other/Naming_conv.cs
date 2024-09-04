//Naming conventions

class Naming_conv               // Класс
{
    public  string  variableName;               //public
    private string  _privateVariableName;       //private

    void LiterallyAnyFunction(int parameter)    //Функция (люб)
    {
        UnityEngine.Debug.Log("" + parameter);
    }

    public string GetVariableName               //get value
    {
        get { return _privateVariableName; }
    }
    public string SetVariableName               //set value
    {
        set { _privateVariableName = value; }
    }
    public string VariableNameOrSomething       //доступ к value
    {
        get { return variableName; }
        set { variableName = value; }
    }
}

interface IExampleInterface                     //Интерфейс (люб)
{
    void Example(string variableName);
}