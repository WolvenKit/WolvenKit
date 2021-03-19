using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_ConsumableAnimation : animAnimFeature
	{
		private CInt32 _consumableType;
		private CBool _useConsumable;

		[Ordinal(0)] 
		[RED("consumableType")] 
		public CInt32 ConsumableType
		{
			get => GetProperty(ref _consumableType);
			set => SetProperty(ref _consumableType, value);
		}

		[Ordinal(1)] 
		[RED("useConsumable")] 
		public CBool UseConsumable
		{
			get => GetProperty(ref _useConsumable);
			set => SetProperty(ref _useConsumable, value);
		}

		public animAnimFeature_ConsumableAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
