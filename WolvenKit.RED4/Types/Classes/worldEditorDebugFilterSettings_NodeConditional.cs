using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldEditorDebugFilterSettings_NodeConditional : worldEditorDebugFilterSettings
	{
		[Ordinal(0)] 
		[RED("isDiscarded")] 
		public CBool IsDiscarded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isProxyDependencyModeAutoSet")] 
		public CBool IsProxyDependencyModeAutoSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isProxyDependencyModeDiscardedSet")] 
		public CBool IsProxyDependencyModeDiscardedSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldEditorDebugFilterSettings_NodeConditional()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
