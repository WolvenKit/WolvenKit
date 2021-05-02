using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtPartRequest : CVariable
	{
		private CName _partName;
		private CFloat _weight;
		private CFloat _suppress;
		private CInt32 _mode;

		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get => GetProperty(ref _partName);
			set => SetProperty(ref _partName, value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(2)] 
		[RED("suppress")] 
		public CFloat Suppress
		{
			get => GetProperty(ref _suppress);
			set => SetProperty(ref _suppress, value);
		}

		[Ordinal(3)] 
		[RED("mode")] 
		public CInt32 Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		public animLookAtPartRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
