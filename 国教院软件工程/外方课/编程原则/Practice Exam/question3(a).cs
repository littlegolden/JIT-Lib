/*
 * (a)
 */
public class Dog: Animal{
	private int inventoryNumber;
	private string breed;
	private string colour;
	private static int totalNumberOfDogs = 0;

	public Dog(): base(0){
		throw new NotImplementedException();
	}

	public Dog(string typeOfBreed, int age, string colour): base(age){
		this.breed = typeOfBreed;
		this.colour = colour;
		totalNumberOfDogs++;
		this.inventoryNumber = totalNumberOfDogs;
	}

	public int InventoryNumber {
		get {
			return this.inventoryNumber;
		}
	}

	public string Breed {
		get {
			return this.breed;
		}
	}

	public string Colour {
		get {
			return this.colour;
		} set {
			this.colour = value;
		}
	}

	public override string ToString(){
		//注意其他方法调用私有变量时，最好使用大写开头的写法如Age，而不是this.age。
		//如果使用this.age，且Animal中的age为私有变量，则会报错，
		//子类无法访问使用'this.'来访问继承于父类或抽象类的私有变量
		return string.Format("The inventory number of this {0} {1} dog is {2}, and it is {3} year old.", Colour, Breed, InventoryNumber, Age);
	}
}
