using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animGenericAnimDatabase_DatabaseRow : CVariable
	{
		private CArray<CInt32> _inputValues;
		private animGenericAnimDatabase_AnimationData _animationData;

		[Ordinal(0)] 
		[RED("inputValues")] 
		public CArray<CInt32> InputValues
		{
			get => GetProperty(ref _inputValues);
			set => SetProperty(ref _inputValues, value);
		}

		[Ordinal(1)] 
		[RED("animationData")] 
		public animGenericAnimDatabase_AnimationData AnimationData
		{
			get => GetProperty(ref _animationData);
			set => SetProperty(ref _animationData, value);
		}

		public animGenericAnimDatabase_DatabaseRow(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
