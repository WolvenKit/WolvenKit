using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadialAnimData : CVariable
	{
		private CName _hover_in;
		private CName _hover_out;
		private CName _cycle_in;
		private CName _cycle_out;

		[Ordinal(0)] 
		[RED("hover_in")] 
		public CName Hover_in
		{
			get => GetProperty(ref _hover_in);
			set => SetProperty(ref _hover_in, value);
		}

		[Ordinal(1)] 
		[RED("hover_out")] 
		public CName Hover_out
		{
			get => GetProperty(ref _hover_out);
			set => SetProperty(ref _hover_out, value);
		}

		[Ordinal(2)] 
		[RED("cycle_in")] 
		public CName Cycle_in
		{
			get => GetProperty(ref _cycle_in);
			set => SetProperty(ref _cycle_in, value);
		}

		[Ordinal(3)] 
		[RED("cycle_out")] 
		public CName Cycle_out
		{
			get => GetProperty(ref _cycle_out);
			set => SetProperty(ref _cycle_out, value);
		}

		public RadialAnimData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
