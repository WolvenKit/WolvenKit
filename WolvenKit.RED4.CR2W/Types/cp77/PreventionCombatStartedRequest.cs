using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionCombatStartedRequest : gameScriptableSystemRequest
	{
		private Vector4 _requesterPosition;
		private wCHandle<gameObject> _requester;

		[Ordinal(0)] 
		[RED("requesterPosition")] 
		public Vector4 RequesterPosition
		{
			get
			{
				if (_requesterPosition == null)
				{
					_requesterPosition = (Vector4) CR2WTypeManager.Create("Vector4", "requesterPosition", cr2w, this);
				}
				return _requesterPosition;
			}
			set
			{
				if (_requesterPosition == value)
				{
					return;
				}
				_requesterPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public PreventionCombatStartedRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
