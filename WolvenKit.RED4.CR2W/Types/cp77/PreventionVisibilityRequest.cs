using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionVisibilityRequest : gameScriptableSystemRequest
	{
		private wCHandle<gameObject> _requester;
		private CBool _seePlayer;

		[Ordinal(0)] 
		[RED("requester")] 
		public wCHandle<gameObject> Requester
		{
			get
			{
				if (_requester == null)
				{
					_requester = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "requester", cr2w, this);
				}
				return _requester;
			}
			set
			{
				if (_requester == value)
				{
					return;
				}
				_requester = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("seePlayer")] 
		public CBool SeePlayer
		{
			get
			{
				if (_seePlayer == null)
				{
					_seePlayer = (CBool) CR2WTypeManager.Create("Bool", "seePlayer", cr2w, this);
				}
				return _seePlayer;
			}
			set
			{
				if (_seePlayer == value)
				{
					return;
				}
				_seePlayer = value;
				PropertySet(this);
			}
		}

		public PreventionVisibilityRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
