using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NemaplateChangedRequest : gameScriptableSystemRequest
	{
		private entEntityID _playerTarget;

		[Ordinal(0)] 
		[RED("playerTarget")] 
		public entEntityID PlayerTarget
		{
			get
			{
				if (_playerTarget == null)
				{
					_playerTarget = (entEntityID) CR2WTypeManager.Create("entEntityID", "playerTarget", cr2w, this);
				}
				return _playerTarget;
			}
			set
			{
				if (_playerTarget == value)
				{
					return;
				}
				_playerTarget = value;
				PropertySet(this);
			}
		}

		public NemaplateChangedRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
