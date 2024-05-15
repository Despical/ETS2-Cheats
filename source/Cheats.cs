using Swed64;

namespace ets2_trainer;

internal class Cheats {

	private readonly Swed swed;
	private readonly IntPtr gameBaseAddress;
	private readonly IntPtr moneyAddress;
	private readonly IntPtr expAddress;

	public Cheats() {
		this.swed = new(Program.MODULE_NAME);
		this.gameBaseAddress = swed.GetModuleBase(Program.MODULE_NAME + ".exe");
		this.moneyAddress = swed.ReadPointer(gameBaseAddress, 0x029E20C0, 0x10) + 0x10;
		this.expAddress = swed.ReadPointer(gameBaseAddress, 0x029E20C0) + 0x196C;
	}

	public void SetMoney(int value) {
		this.swed.WriteInt(this.moneyAddress, value);
	}

	public void SetExp(int value) {
		this.swed.WriteInt(this.expAddress, value);
	}
}