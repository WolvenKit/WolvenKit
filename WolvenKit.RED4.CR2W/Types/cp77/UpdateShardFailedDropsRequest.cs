using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdateShardFailedDropsRequest : gameScriptableSystemRequest
	{
		private CBool _resetCounter;
		private CFloat _newFailedAttempts;

		[Ordinal(0)] 
		[RED("resetCounter")] 
		public CBool ResetCounter
		{
			get
			{
				if (_resetCounter == null)
				{
					_resetCounter = (CBool) CR2WTypeManager.Create("Bool", "resetCounter", cr2w, this);
				}
				return _resetCounter;
			}
			set
			{
				if (_resetCounter == value)
				{
					return;
				}
				_resetCounter = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("newFailedAttempts")] 
		public CFloat NewFailedAttempts
		{
			get
			{
				if (_newFailedAttempts == null)
				{
					_newFailedAttempts = (CFloat) CR2WTypeManager.Create("Float", "newFailedAttempts", cr2w, this);
				}
				return _newFailedAttempts;
			}
			set
			{
				if (_newFailedAttempts == value)
				{
					return;
				}
				_newFailedAttempts = value;
				PropertySet(this);
			}
		}

		public UpdateShardFailedDropsRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
