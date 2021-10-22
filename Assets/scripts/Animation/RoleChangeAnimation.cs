using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoleChangeAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator _NameAnim;
    [SerializeField]
    private Animator _NameLabelAnim;
    [SerializeField]
    private Animator _ShibariAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!v.start_flag)
        {
            _NameAnim.SetBool("blExp" ,true);
            _NameLabelAnim.SetBool("blExp2", true);
            _ShibariAnim.SetBool("blShibari", true);
        }
    }
}
