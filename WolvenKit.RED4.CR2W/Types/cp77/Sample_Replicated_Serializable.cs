using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Sample_Replicated_Serializable : ISerializable
	{
		private CBool _property;

		[Ordinal(0)] 
		[RED("property")] 
		public CBool Property
		{
			get => GetProperty(ref _property);
			set => SetProperty(ref _property, value);
		}

		public Sample_Replicated_Serializable(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
