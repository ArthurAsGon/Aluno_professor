public class Person{
    private String name;
    private String address;

    public Person(String name, String address) {
        this.name = name;
        this.address = address;
    }
    public String getName() {
        return this.name;
    }
    public String getAddress(){
        return this.address;
    }
    public override bool Equals(object obj)
    {       
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }        
        
        throw new System.NotImplementedException();
        
    }
    
    public String toString(){
        return $"Person, name = {this.name}, address {this.address} ";
    }






}