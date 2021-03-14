using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnDialogLineDuplicationParams : CVariable
	{
		private CUInt8 _executionTag;
		private scnActorId _additionalSpeakerId;
		private CBool _isHolocallSpeaker;

		[Ordinal(0)] 
		[RED("executionTag")] 
		public CUInt8 ExecutionTag
		{
			get
			{
				if (_executionTag == null)
				{
					_executionTag = (CUInt8) CR2WTypeManager.Create("Uint8", "executionTag", cr2w, this);
				}
				return _executionTag;
			}
			set
			{
				if (_executionTag == value)
				{
					return;
				}
				_executionTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("additionalSpeakerId")] 
		public scnActorId AdditionalSpeakerId
		{
			get
			{
				if (_additionalSpeakerId == null)
				{
					_additionalSpeakerId = (scnActorId) CR2WTypeManager.Create("scnActorId", "additionalSpeakerId", cr2w, this);
				}
				return _additionalSpeakerId;
			}
			set
			{
				if (_additionalSpeakerId == value)
				{
					return;
				}
				_additionalSpeakerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isHolocallSpeaker")] 
		public CBool IsHolocallSpeaker
		{
			get
			{
				if (_isHolocallSpeaker == null)
				{
					_isHolocallSpeaker = (CBool) CR2WTypeManager.Create("Bool", "isHolocallSpeaker", cr2w, this);
				}
				return _isHolocallSpeaker;
			}
			set
			{
				if (_isHolocallSpeaker == value)
				{
					return;
				}
				_isHolocallSpeaker = value;
				PropertySet(this);
			}
		}

		public scnDialogLineDuplicationParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
