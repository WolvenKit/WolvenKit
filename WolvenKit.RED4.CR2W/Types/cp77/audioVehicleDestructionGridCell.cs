using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleDestructionGridCell : CVariable
	{
		private CName _impactEvent;
		private CName _impactDetailEvent;

		[Ordinal(0)] 
		[RED("impactEvent")] 
		public CName ImpactEvent
		{
			get
			{
				if (_impactEvent == null)
				{
					_impactEvent = (CName) CR2WTypeManager.Create("CName", "impactEvent", cr2w, this);
				}
				return _impactEvent;
			}
			set
			{
				if (_impactEvent == value)
				{
					return;
				}
				_impactEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("impactDetailEvent")] 
		public CName ImpactDetailEvent
		{
			get
			{
				if (_impactDetailEvent == null)
				{
					_impactDetailEvent = (CName) CR2WTypeManager.Create("CName", "impactDetailEvent", cr2w, this);
				}
				return _impactDetailEvent;
			}
			set
			{
				if (_impactDetailEvent == value)
				{
					return;
				}
				_impactDetailEvent = value;
				PropertySet(this);
			}
		}

		public audioVehicleDestructionGridCell(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
