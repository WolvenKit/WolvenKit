using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceCaptionBluelinePart : gameinteractionsChoiceCaptionPart
	{
		private CHandle<gameinteractionsvisBluelineDescription> _blueline;

		[Ordinal(0)] 
		[RED("blueline")] 
		public CHandle<gameinteractionsvisBluelineDescription> Blueline
		{
			get
			{
				if (_blueline == null)
				{
					_blueline = (CHandle<gameinteractionsvisBluelineDescription>) CR2WTypeManager.Create("handle:gameinteractionsvisBluelineDescription", "blueline", cr2w, this);
				}
				return _blueline;
			}
			set
			{
				if (_blueline == value)
				{
					return;
				}
				_blueline = value;
				PropertySet(this);
			}
		}

		public gameinteractionsChoiceCaptionBluelinePart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
