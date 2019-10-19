package md557a1a3d1d70d6ee40dfa26496bcf1bb3;


public class BorderEntryRenderer
	extends md51558244f76c53b6aeda52c8a337f2c37.EntryRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("IRESProject.Droid.Renderers.BorderEntryRenderer, IRESProject.Android", BorderEntryRenderer.class, __md_methods);
	}


	public BorderEntryRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == BorderEntryRenderer.class)
			mono.android.TypeManager.Activate ("IRESProject.Droid.Renderers.BorderEntryRenderer, IRESProject.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public BorderEntryRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == BorderEntryRenderer.class)
			mono.android.TypeManager.Activate ("IRESProject.Droid.Renderers.BorderEntryRenderer, IRESProject.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public BorderEntryRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == BorderEntryRenderer.class)
			mono.android.TypeManager.Activate ("IRESProject.Droid.Renderers.BorderEntryRenderer, IRESProject.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
