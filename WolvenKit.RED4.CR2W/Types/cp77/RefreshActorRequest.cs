using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RefreshActorRequest : HUDManagerRequest
	{
		private CHandle<HUDActorUpdateData> _actorUpdateData;
		private CArray<wCHandle<HUDModule>> _requestedModules;

		[Ordinal(1)] 
		[RED("actorUpdateData")] 
		public CHandle<HUDActorUpdateData> ActorUpdateData
		{
			get
			{
				if (_actorUpdateData == null)
				{
					_actorUpdateData = (CHandle<HUDActorUpdateData>) CR2WTypeManager.Create("handle:HUDActorUpdateData", "actorUpdateData", cr2w, this);
				}
				return _actorUpdateData;
			}
			set
			{
				if (_actorUpdateData == value)
				{
					return;
				}
				_actorUpdateData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("requestedModules")] 
		public CArray<wCHandle<HUDModule>> RequestedModules
		{
			get
			{
				if (_requestedModules == null)
				{
					_requestedModules = (CArray<wCHandle<HUDModule>>) CR2WTypeManager.Create("array:whandle:HUDModule", "requestedModules", cr2w, this);
				}
				return _requestedModules;
			}
			set
			{
				if (_requestedModules == value)
				{
					return;
				}
				_requestedModules = value;
				PropertySet(this);
			}
		}

		public RefreshActorRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
