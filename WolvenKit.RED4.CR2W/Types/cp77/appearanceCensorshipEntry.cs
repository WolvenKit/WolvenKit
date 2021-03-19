using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class appearanceCensorshipEntry : CVariable
	{
		private CName _original;
		private CName _censored;
		private CUInt32 _censorFlags;

		[Ordinal(0)] 
		[RED("Original")] 
		public CName Original
		{
			get => GetProperty(ref _original);
			set => SetProperty(ref _original, value);
		}

		[Ordinal(1)] 
		[RED("Censored")] 
		public CName Censored
		{
			get => GetProperty(ref _censored);
			set => SetProperty(ref _censored, value);
		}

		[Ordinal(2)] 
		[RED("CensorFlags")] 
		public CUInt32 CensorFlags
		{
			get => GetProperty(ref _censorFlags);
			set => SetProperty(ref _censorFlags, value);
		}

		public appearanceCensorshipEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
