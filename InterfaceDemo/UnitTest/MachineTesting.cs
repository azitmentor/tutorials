using Module1.Interfaces;
using Module1.Services;

namespace UnitTest
{
	public class MachineTesting
	{
		//FIRST

		[Fact]
		public void Start_test()
		{
			//AAA
			//Arrange
			var machine = new Machine();
			
			//Act
			var result = machine.Start();

			//Assert
			Assert.True(result);
			Assert.Equal(MachineState.Running, machine.State);
		}

		[Fact]
		public void StartNonzero_test()
		{
			//AAA
			//Arrange
			var machine = new Machine();
			machine.SetSpeed(40);

			//Act
			var result = machine.Start();

			//Assert
			Assert.False(result);
			Assert.Equal(MachineState.Stopped, machine.State);
		}

		[Fact]
		public void Stop_test()
		{
			//AAA
			//Arrange
			var machine = new Machine();

			//Act
			var result = machine.Stop();

			//Assert
			Assert.True(result);
			Assert.Equal(MachineState.Stopped, machine.State);
		}
	}
}