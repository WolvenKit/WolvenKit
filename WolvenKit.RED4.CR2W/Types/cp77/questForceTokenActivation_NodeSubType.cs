using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questForceTokenActivation_NodeSubType : questIContentTokenManager_NodeSubType
	{
		private CBool _forceCreatingToken;

		[Ordinal(0)] 
		[RED("forceCreatingToken")] 
		public CBool ForceCreatingToken
		{
			get => GetProperty(ref _forceCreatingToken);
			set => SetProperty(ref _forceCreatingToken, value);
		}

		public questForceTokenActivation_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
