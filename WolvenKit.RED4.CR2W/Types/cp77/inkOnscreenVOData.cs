using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkOnscreenVOData : CVariable
	{
		private CRUID _text;

		[Ordinal(0)] 
		[RED("text")] 
		public CRUID Text
		{
			get
			{
				if (_text == null)
				{
					_text = (CRUID) CR2WTypeManager.Create("CRUID", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		public inkOnscreenVOData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
