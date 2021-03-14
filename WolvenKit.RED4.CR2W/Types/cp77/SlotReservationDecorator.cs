using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SlotReservationDecorator : AIVehicleTaskAbstract
	{
		private CHandle<AIArgumentMapping> _mountData;
		private CHandle<gameMountEventData> _mountEventData;

		[Ordinal(0)] 
		[RED("mountData")] 
		public CHandle<AIArgumentMapping> MountData
		{
			get
			{
				if (_mountData == null)
				{
					_mountData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "mountData", cr2w, this);
				}
				return _mountData;
			}
			set
			{
				if (_mountData == value)
				{
					return;
				}
				_mountData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mountEventData")] 
		public CHandle<gameMountEventData> MountEventData
		{
			get
			{
				if (_mountEventData == null)
				{
					_mountEventData = (CHandle<gameMountEventData>) CR2WTypeManager.Create("handle:gameMountEventData", "mountEventData", cr2w, this);
				}
				return _mountEventData;
			}
			set
			{
				if (_mountEventData == value)
				{
					return;
				}
				_mountEventData = value;
				PropertySet(this);
			}
		}

		public SlotReservationDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
