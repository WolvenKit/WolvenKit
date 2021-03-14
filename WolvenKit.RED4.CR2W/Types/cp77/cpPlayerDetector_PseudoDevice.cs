using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpPlayerDetector_PseudoDevice : gameObject
	{
		private NodeRef _playerDetector;

		[Ordinal(40)] 
		[RED("playerDetector")] 
		public NodeRef PlayerDetector
		{
			get
			{
				if (_playerDetector == null)
				{
					_playerDetector = (NodeRef) CR2WTypeManager.Create("NodeRef", "playerDetector", cr2w, this);
				}
				return _playerDetector;
			}
			set
			{
				if (_playerDetector == value)
				{
					return;
				}
				_playerDetector = value;
				PropertySet(this);
			}
		}

		public cpPlayerDetector_PseudoDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
