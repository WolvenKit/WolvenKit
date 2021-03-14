using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Stagger : ReactionTransition
	{
		private CUInt32 _textLayerId;

		[Ordinal(0)] 
		[RED("textLayerId")] 
		public CUInt32 TextLayerId
		{
			get
			{
				if (_textLayerId == null)
				{
					_textLayerId = (CUInt32) CR2WTypeManager.Create("Uint32", "textLayerId", cr2w, this);
				}
				return _textLayerId;
			}
			set
			{
				if (_textLayerId == value)
				{
					return;
				}
				_textLayerId = value;
				PropertySet(this);
			}
		}

		public Stagger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
