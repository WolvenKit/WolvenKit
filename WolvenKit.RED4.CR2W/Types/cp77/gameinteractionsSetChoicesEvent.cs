using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsSetChoicesEvent : redEvent
	{
		private CArray<gameinteractionsChoice> _choices;
		private CName _layer;

		[Ordinal(0)] 
		[RED("choices")] 
		public CArray<gameinteractionsChoice> Choices
		{
			get => GetProperty(ref _choices);
			set => SetProperty(ref _choices, value);
		}

		[Ordinal(1)] 
		[RED("layer")] 
		public CName Layer
		{
			get => GetProperty(ref _layer);
			set => SetProperty(ref _layer, value);
		}

		public gameinteractionsSetChoicesEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
