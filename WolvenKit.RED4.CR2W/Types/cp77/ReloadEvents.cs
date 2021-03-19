using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReloadEvents : WeaponEventsTransition
	{
		private CHandle<AnimFeature_SelectRandomAnimSync> _randomSync;
		private CBool _sprintingLastUpdate;
		private CBool _uninteruptibleSet;

		[Ordinal(0)] 
		[RED("randomSync")] 
		public CHandle<AnimFeature_SelectRandomAnimSync> RandomSync
		{
			get => GetProperty(ref _randomSync);
			set => SetProperty(ref _randomSync, value);
		}

		[Ordinal(1)] 
		[RED("sprintingLastUpdate")] 
		public CBool SprintingLastUpdate
		{
			get => GetProperty(ref _sprintingLastUpdate);
			set => SetProperty(ref _sprintingLastUpdate, value);
		}

		[Ordinal(2)] 
		[RED("uninteruptibleSet")] 
		public CBool UninteruptibleSet
		{
			get => GetProperty(ref _uninteruptibleSet);
			set => SetProperty(ref _uninteruptibleSet, value);
		}

		public ReloadEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
