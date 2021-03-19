using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehiclePartSettingsMapItem : CVariable
	{
		private CName _name;
		private CName _onDetachEvent;
		private CFloat _onDetachAcousticsIsolationFactorReduction;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("onDetachEvent")] 
		public CName OnDetachEvent
		{
			get => GetProperty(ref _onDetachEvent);
			set => SetProperty(ref _onDetachEvent, value);
		}

		[Ordinal(2)] 
		[RED("onDetachAcousticsIsolationFactorReduction")] 
		public CFloat OnDetachAcousticsIsolationFactorReduction
		{
			get => GetProperty(ref _onDetachAcousticsIsolationFactorReduction);
			set => SetProperty(ref _onDetachAcousticsIsolationFactorReduction, value);
		}

		public audioVehiclePartSettingsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
