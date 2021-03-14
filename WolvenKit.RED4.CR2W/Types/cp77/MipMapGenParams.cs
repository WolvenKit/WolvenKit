using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MipMapGenParams : CVariable
	{
		private CBool _applyToksvig_ShouldInvChannel;
		private CUInt8 _applyToksvig_Channel;
		private raRef<CBitmapTexture> _applyToksvig_sourceNormalMap;

		[Ordinal(0)] 
		[RED("applyToksvig_ShouldInvChannel")] 
		public CBool ApplyToksvig_ShouldInvChannel
		{
			get
			{
				if (_applyToksvig_ShouldInvChannel == null)
				{
					_applyToksvig_ShouldInvChannel = (CBool) CR2WTypeManager.Create("Bool", "applyToksvig_ShouldInvChannel", cr2w, this);
				}
				return _applyToksvig_ShouldInvChannel;
			}
			set
			{
				if (_applyToksvig_ShouldInvChannel == value)
				{
					return;
				}
				_applyToksvig_ShouldInvChannel = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("applyToksvig_Channel")] 
		public CUInt8 ApplyToksvig_Channel
		{
			get
			{
				if (_applyToksvig_Channel == null)
				{
					_applyToksvig_Channel = (CUInt8) CR2WTypeManager.Create("Uint8", "applyToksvig_Channel", cr2w, this);
				}
				return _applyToksvig_Channel;
			}
			set
			{
				if (_applyToksvig_Channel == value)
				{
					return;
				}
				_applyToksvig_Channel = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("applyToksvig_sourceNormalMap")] 
		public raRef<CBitmapTexture> ApplyToksvig_sourceNormalMap
		{
			get
			{
				if (_applyToksvig_sourceNormalMap == null)
				{
					_applyToksvig_sourceNormalMap = (raRef<CBitmapTexture>) CR2WTypeManager.Create("raRef:CBitmapTexture", "applyToksvig_sourceNormalMap", cr2w, this);
				}
				return _applyToksvig_sourceNormalMap;
			}
			set
			{
				if (_applyToksvig_sourceNormalMap == value)
				{
					return;
				}
				_applyToksvig_sourceNormalMap = value;
				PropertySet(this);
			}
		}

		public MipMapGenParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
