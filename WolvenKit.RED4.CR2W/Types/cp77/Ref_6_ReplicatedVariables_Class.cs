using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Ref_6_ReplicatedVariables_Class : IScriptable
	{
		private CInt32 _thisIsReplicatedFieldInClass;

		[Ordinal(0)] 
		[RED("thisIsReplicatedFieldInClass")] 
		public CInt32 ThisIsReplicatedFieldInClass
		{
			get => GetProperty(ref _thisIsReplicatedFieldInClass);
			set => SetProperty(ref _thisIsReplicatedFieldInClass, value);
		}

		public Ref_6_ReplicatedVariables_Class(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
