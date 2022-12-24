namespace Module1.Interfaces
{
	public interface IMachine
	{
		bool Start();
		bool Stop();
		void SetSpeed(int newSpeed);
		MachineState State { get; }
		int Speed { get; }
	}

	public enum MachineState
	{
		Stopped,
		Running,
		Failed
	}

}
