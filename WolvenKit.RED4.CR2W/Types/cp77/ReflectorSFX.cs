using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReflectorSFX : VendingMachineSFX
	{
		private CName _distraction;
		private CName _turnOn;
		private CName _turnOff;

		[Ordinal(2)] 
		[RED("distraction")] 
		public CName Distraction
		{
			get => GetProperty(ref _distraction);
			set => SetProperty(ref _distraction, value);
		}

		[Ordinal(3)] 
		[RED("turnOn")] 
		public CName TurnOn
		{
			get => GetProperty(ref _turnOn);
			set => SetProperty(ref _turnOn, value);
		}

		[Ordinal(4)] 
		[RED("turnOff")] 
		public CName TurnOff
		{
			get => GetProperty(ref _turnOff);
			set => SetProperty(ref _turnOff, value);
		}

		public ReflectorSFX(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
