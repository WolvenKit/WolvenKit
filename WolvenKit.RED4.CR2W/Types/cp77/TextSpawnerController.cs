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
			get
			{
				if (_amountOfRows == null)
				{
					_amountOfRows = (CInt32) CR2WTypeManager.Create("Int32", "amountOfRows", cr2w, this);
				}
				return _amountOfRows;
			}
			set
			{
				if (_amountOfRows == value)
				{
					return;
				}
				_amountOfRows = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lineTextWidgetID")] 
		public CName LineTextWidgetID
		{
			get
			{
				if (_lineTextWidgetID == null)
				{
					_lineTextWidgetID = (CName) CR2WTypeManager.Create("CName", "lineTextWidgetID", cr2w, this);
				}
				return _lineTextWidgetID;
			}
			set
			{
				if (_lineTextWidgetID == value)
				{
					return;
				}
				_lineTextWidgetID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("texts")] 
		public CArray<wCHandle<inkWidget>> Texts
		{
			get
			{
				if (_texts == null)
				{
					_texts = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "texts", cr2w, this);
				}
				return _texts;
			}
			set
			{
				if (_texts == value)
				{
					return;
				}
				_texts = value;
				PropertySet(this);
			}
		}

		public TextSpawnerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
