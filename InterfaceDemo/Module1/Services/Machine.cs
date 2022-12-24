using Module1.Interfaces;

namespace Module1.Services
{
	public class Machine : IMachine
	{
		public MachineState State { get; private set; }

		public int Speed { get; private set; }

		public void SetSpeed(int newSpeed)
		{
			Speed = newSpeed;
		}

		public bool Start()
		{
			if (Speed != 0)
			{
				return false;
			}
			State = MachineState.Running;
			return true;
		}

		public bool Stop()
		{
			State = MachineState.Stopped;
			return true;
		}
	}
}
