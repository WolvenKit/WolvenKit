using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConstantStatPoolPrereqState : StatPoolPrereqState
	{
		private CBool _listenConstantly;

		[Ordinal(1)] 
		[RED("listenConstantly")] 
		public CBool ListenConstantly
		{
			get
			{
				if (_listenConstantly == null)
				{
					_listenConstantly = (CBool) CR2WTypeManager.Create("Bool", "listenConstantly", cr2w, this);
				}
				return _listenConstantly;
			}
			set
			{
				if (_listenConstantly == value)
				{
					return;
				}
				_listenConstantly = value;
				PropertySet(this);
			}
		}

		public ConstantStatPoolPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
