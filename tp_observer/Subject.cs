public class Subject : ISubject {
    public string value = "valeur";
    public string GetValue(){
        return value;
     }
    
    public void SetValue(string value)
    {
        this.value = value;
    }
    public bool IsRegistered(IObserver o){
        return true;
    }
    public void RegisterObserver(IObserver o){}
    public void UnRegisterObserver(IObserver o){}
}