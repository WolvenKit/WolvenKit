using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TarotCardAdded : redEvent
	{
		private CName _imagePart;
		private CString _cardName;

		[Ordinal(0)] 
		[RED("imagePart")] 
		public CName ImagePart
		{
			get
			{
				if (_imagePart == null)
				{
					_imagePart = (CName) CR2WTypeManager.Create("CName", "imagePart", cr2w, this);
				}
				return _imagePart;
			}
			set
			{
				if (_imagePart == value)
				{
					return;
				}
				_imagePart = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cardName")] 
		public CString CardName
		{
			get
			{
				if (_cardName == null)
				{
					_cardName = (CString) CR2WTypeManager.Create("String", "cardName", cr2w, this);
				}
				return _cardName;
			}
			set
			{
				if (_cardName == value)
				{
					return;
				}
				_cardName = value;
				PropertySet(this);
			}
		}

		public TarotCardAdded(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
