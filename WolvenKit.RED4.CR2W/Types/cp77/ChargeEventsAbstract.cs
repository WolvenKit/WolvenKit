using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChargeEventsAbstract : WeaponEventsTransition
	{
		private CUInt32 _layerId;

		[Ordinal(0)] 
		[RED("layerId")] 
		public CUInt32 LayerId
		{
			get
			{
				if (_layerId == null)
				{
					_layerId = (CUInt32) CR2WTypeManager.Create("Uint32", "layerId", cr2w, this);
				}
				return _layerId;
			}
			set
			{
				if (_layerId == value)
				{
					return;
				}
				_layerId = value;
				PropertySet(this);
			}
		}

		public ChargeEventsAbstract(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
