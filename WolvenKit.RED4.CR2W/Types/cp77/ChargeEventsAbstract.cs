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
			get => GetProperty(ref _layerId);
			set => SetProperty(ref _layerId, value);
		}

		public ChargeEventsAbstract(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
