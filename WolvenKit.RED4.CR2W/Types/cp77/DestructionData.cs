using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DestructionData : CVariable
	{
		private CEnum<EDeviceDurabilityType> _durabilityType;
		private CBool _canBeFixed;

		[Ordinal(0)] 
		[RED("durabilityType")] 
		public CEnum<EDeviceDurabilityType> DurabilityType
		{
			get => GetProperty(ref _durabilityType);
			set => SetProperty(ref _durabilityType, value);
		}

		[Ordinal(1)] 
		[RED("canBeFixed")] 
		public CBool CanBeFixed
		{
			get => GetProperty(ref _canBeFixed);
			set => SetProperty(ref _canBeFixed, value);
		}

		public DestructionData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
