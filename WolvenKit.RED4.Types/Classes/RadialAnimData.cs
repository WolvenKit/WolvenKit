using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RadialAnimData : RedBaseClass
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

		public RadialAnimData()
		{
			_hover_in = "Anim name for hover in";
			_hover_out = "Anim name for hover out";
			_cycle_in = "Anim name for cycle in animation";
			_cycle_out = "Anim name for cycle out animation";
		}
	}
}
