using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TextSpawnerController : inkWidgetLogicController
	{
		private CInt32 _amountOfRows;
		private CName _lineTextWidgetID;
		private CArray<wCHandle<inkWidget>> _texts;

		[Ordinal(1)] 
		[RED("amountOfRows")] 
		public CInt32 AmountOfRows
		{
			get => GetProperty(ref _amountOfRows);
			set => SetProperty(ref _amountOfRows, value);
		}

		[Ordinal(2)] 
		[RED("lineTextWidgetID")] 
		public CName LineTextWidgetID
		{
			get => GetProperty(ref _lineTextWidgetID);
			set => SetProperty(ref _lineTextWidgetID, value);
		}

		[Ordinal(3)] 
		[RED("texts")] 
		public CArray<wCHandle<inkWidget>> Texts
		{
			get => GetProperty(ref _texts);
			set => SetProperty(ref _texts, value);
		}

		public TextSpawnerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
