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
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("onDetachEvent")] 
		public CName OnDetachEvent
		{
			get
			{
				if (_onDetachEvent == null)
				{
					_onDetachEvent = (CName) CR2WTypeManager.Create("CName", "onDetachEvent", cr2w, this);
				}
				return _onDetachEvent;
			}
			set
			{
				if (_onDetachEvent == value)
				{
					return;
				}
				_onDetachEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("onDetachAcousticsIsolationFactorReduction")] 
		public CFloat OnDetachAcousticsIsolationFactorReduction
		{
			get
			{
				if (_onDetachAcousticsIsolationFactorReduction == null)
				{
					_onDetachAcousticsIsolationFactorReduction = (CFloat) CR2WTypeManager.Create("Float", "onDetachAcousticsIsolationFactorReduction", cr2w, this);
				}
				return _onDetachAcousticsIsolationFactorReduction;
			}
			set
			{
				if (_onDetachAcousticsIsolationFactorReduction == value)
				{
					return;
				}
				_onDetachAcousticsIsolationFactorReduction = value;
				PropertySet(this);
			}
		}

		public audioVehiclePartSettingsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
