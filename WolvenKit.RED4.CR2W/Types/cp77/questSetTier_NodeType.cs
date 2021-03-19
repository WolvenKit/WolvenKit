using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetTier_NodeType : questISceneManagerNodeType
	{
		private CEnum<GameplayTier> _tier;
		private CBool _usePlayerWorkspot;
		private CBool _useEnterAnim;
		private CBool _useExitAnim;
		private CBool _forceEmptyHands;

		[Ordinal(0)] 
		[RED("tier")] 
		public CEnum<GameplayTier> Tier
		{
			get => GetProperty(ref _tier);
			set => SetProperty(ref _tier, value);
		}

		[Ordinal(1)] 
		[RED("usePlayerWorkspot")] 
		public CBool UsePlayerWorkspot
		{
			get => GetProperty(ref _usePlayerWorkspot);
			set => SetProperty(ref _usePlayerWorkspot, value);
		}

		[Ordinal(2)] 
		[RED("useEnterAnim")] 
		public CBool UseEnterAnim
		{
			get => GetProperty(ref _useEnterAnim);
			set => SetProperty(ref _useEnterAnim, value);
		}

		[Ordinal(3)] 
		[RED("useExitAnim")] 
		public CBool UseExitAnim
		{
			get => GetProperty(ref _useExitAnim);
			set => SetProperty(ref _useExitAnim, value);
		}

		[Ordinal(4)] 
		[RED("forceEmptyHands")] 
		public CBool ForceEmptyHands
		{
			get => GetProperty(ref _forceEmptyHands);
			set => SetProperty(ref _forceEmptyHands, value);
		}

		public questSetTier_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
