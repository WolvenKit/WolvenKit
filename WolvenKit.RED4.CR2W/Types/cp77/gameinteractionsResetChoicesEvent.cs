using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsResetChoicesEvent : redEvent
	{
		private CName _layer;

		[Ordinal(0)] 
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

		public gameinteractionsResetChoicesEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
