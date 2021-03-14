using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeakFenceSetup : CVariable
	{
		private CBool _hasGenericInteraction;

		[Ordinal(0)] 
		[RED("hasGenericInteraction")] 
		public CBool HasGenericInteraction
		{
			get
			{
				if (_hasGenericInteraction == null)
				{
					_hasGenericInteraction = (CBool) CR2WTypeManager.Create("Bool", "hasGenericInteraction", cr2w, this);
				}
				return _hasGenericInteraction;
			}
			set
			{
				if (_hasGenericInteraction == value)
				{
					return;
				}
				_hasGenericInteraction = value;
				PropertySet(this);
			}
		}

		public WeakFenceSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
