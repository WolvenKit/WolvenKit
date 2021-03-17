using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StagePoseEntry : animAnimNode_Base
	{
		private CName _inputName;
		private animPoseLink _parentInput;

		[Ordinal(11)] 
		[RED("inputName")] 
		public CName InputName
		{
			get => GetProperty(ref _inputName);
			set => SetProperty(ref _inputName, value);
		}

		[Ordinal(12)] 
		[RED("parentInput")] 
		public animPoseLink ParentInput
		{
			get => GetProperty(ref _parentInput);
			set => SetProperty(ref _parentInput, value);
		}

		public animAnimNode_StagePoseEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
