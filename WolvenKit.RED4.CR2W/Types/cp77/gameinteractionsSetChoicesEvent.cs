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
			get
			{
				if (_choices == null)
				{
					_choices = (CArray<gameinteractionsChoice>) CR2WTypeManager.Create("array:gameinteractionsChoice", "choices", cr2w, this);
				}
				return _choices;
			}
			set
			{
				if (_choices == value)
				{
					return;
				}
				_choices = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("layer")] 
		public CName Layer
		{
			get
			{
				if (_layer == null)
				{
					_layer = (CName) CR2WTypeManager.Create("CName", "layer", cr2w, this);
				}
				return _layer;
			}
			set
			{
				if (_layer == value)
				{
					return;
				}
				_layer = value;
				PropertySet(this);
			}
		}

		public gameinteractionsSetChoicesEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
