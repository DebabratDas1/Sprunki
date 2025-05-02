using System.Threading.Tasks;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using DD.Web3;
public class DragAndDrop : MonoBehaviour
{
    private Vector3 _originalPosition;  // Store the original position of the object
    private bool _isDragging = false;   // Track if the object is being dragged
    private Transform _currentDropTarget = null;  // Store the current valid drop target
    GameObject currentTragetCharacter;
    public bool Orange, Red ,gray,robo,green,kat,stel,phone,greenHead, aqua, sun, horns, tree, yellow , hat , laptop , white , pink , blue ,blackhat;
    private void Start()
    {
        // Store the initial position of the object
        _originalPosition = transform.position;
        
    }
   
    private void OnMouseDown()
    {
        // Start dragging the object
        _isDragging = true;
    }

    private void OnMouseDrag()
    {
        if (_isDragging)
        {
            // Move the object to follow the mouse position
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;  // Keep the object in the 2D plane
            transform.position = mousePosition;
        }
    }

    private async void OnMouseUp()
    {
        // Stop dragging when the mouse is released
        _isDragging = false;

        if (_currentDropTarget != null)
        {
            if (BlockchainManager.Instance != null)
            {
                // Await MockClaimNFT() to get the result
                bool claimSuccess = await BlockchainManager.Instance.connectionManager.ClaimDropERC721();

                if (!claimSuccess)
                {
                    StartCoroutine(SmoothReturn());
                    return;
                }
            }
            


            // If dropped on a valid target, snap to the target position



            transform.position = _currentDropTarget.position;
            gameObject.SetActive(false);
            foreach (GameObject item in Gamemanager.instnce.AllPopupButtons)
            {
                item.SetActive(false);
            }
            Gamemanager.instnce.ResumAudios();
            if (Orange == true)
            {
                GetComponent<OrangeButton>().OrangeAudio.Play();
                GetComponent<OrangeButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 1);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<OrangeButton>().OrangeAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;

            }
            else if (Red ==  true)
            {
                GetComponent<redButton>().RedAudio.Play();
                GetComponent<redButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 2);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<redButton>().RedAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (gray == true)
            {
                GetComponent<GrayButton>().Grayaudio.Play();
                GetComponent<GrayButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 3);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<GrayButton>().Grayaudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (robo == true)
            {
                GetComponent<RoboButton>().Roboaudio.Play();
                GetComponent<RoboButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 4);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<RoboButton>().Roboaudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (green == true)
            {
                GetComponent<GreenButton>().GreenAudio.Play();
                GetComponent<GreenButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 5);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<GreenButton>().GreenAudio; currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (kat == true)
            {
                GetComponent<KatButton>().KatAudio.Play();
                GetComponent<KatButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 6);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<KatButton>().KatAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (stel == true)
            {
                GetComponent<StelButton>().StelAudio.Play();
                GetComponent<StelButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 7);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<StelButton>().StelAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (phone == true)
            {
                GetComponent<PhoneButton>().GreenAudio.Play();
                GetComponent<PhoneButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 8);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<PhoneButton>().GreenAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (greenHead == true)
            {
                GetComponent<GreenHeadButton>().GreenHeadAudio.Play();
                GetComponent<GreenHeadButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 9);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<GreenHeadButton>().GreenHeadAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (aqua == true)
            {
                GetComponent<AquaButton>().AquaAudio.Play();
                GetComponent<AquaButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 10);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<AquaButton>().AquaAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (sun == true)
            {
                GetComponent<SunButton>().SunAudio.Play();
                GetComponent<SunButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 11);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<SunButton>().SunAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (horns == true)
            {
                GetComponent<HorensButton>().HorensAudio.Play();
                GetComponent<HorensButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 12);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<HorensButton>().HorensAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (tree == true)
            {
                GetComponent<TreeButton>().TreeAudio.Play();
                GetComponent<TreeButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 13);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<TreeButton>().TreeAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (yellow == true)
            {
                GetComponent<YellowButton>().YellowAudio.Play();
                GetComponent<YellowButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 14);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<YellowButton>().YellowAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (hat == true)
            {
                GetComponent<HatButton>().HatAudio.Play();
                GetComponent<HatButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 15);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<HatButton>().HatAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (laptop == true)
            {
                GetComponent<LaptopButton>().LaptopAudio.Play();
                GetComponent<LaptopButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 16);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<LaptopButton>().LaptopAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (white == true)
            {
                GetComponent<whitebutton>().whiteAudio.Play();
                GetComponent<whitebutton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 17);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<whitebutton>().whiteAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (pink == true)
            {
                GetComponent<pinkButton>().PinkAudio.Play();
                GetComponent<pinkButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 18);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<pinkButton>().PinkAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (blue == true)
            {
                GetComponent<BluebUtton>().BlueAudio.Play();
                GetComponent<BluebUtton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 19);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<BluebUtton>().BlueAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
            }
            else if (blackhat == true)
            {
                GetComponent<BlackButton>().BlackAudio.Play();
                GetComponent<BlackButton>().mybackgroundImage.SetActive(true);
                currentTragetCharacter.GetComponent<Animator>().enabled = true;
                currentTragetCharacter.GetComponent<Animator>().SetInteger("mov", 20);
                currentTragetCharacter.gameObject.tag = "none";
                currentTragetCharacter.GetComponent<character>().MycurrentlyAudio = GetComponent<BlackButton>().BlackAudio;
                currentTragetCharacter.GetComponent<character>().IsAudioOn = true;
                currentTragetCharacter.GetComponent<character>().MyButton = gameObject;
                if(SceneManager.GetActiveScene().buildIndex == 1)
                {
                    SceneManager.LoadScene(2);
                }
            }
            if(Gamemanager.instnce.count == 6)
            {
                AdsManagerX.instance.adsongameover();
                Gamemanager.instnce.count = 0;
            }
            else
            {
                Gamemanager.instnce.count++;
            }
        }
        else
        {
            // If not dropped on a valid target, smoothly return to the original position
            StartCoroutine(SmoothReturn());
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the collided object is a valid drop target
        if (other.CompareTag("DropTarget"))
        {
            _currentDropTarget = other.transform;
            currentTragetCharacter = other.gameObject;


        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        // Clear the current drop target when the object exits the collider
        if (other.CompareTag("DropTarget") && _currentDropTarget == other.transform)
        {
            _currentDropTarget = null;
        }
    }

    private System.Collections.IEnumerator SmoothReturn()
    {
        // Smoothly move the object back to its original position
        float elapsedTime = 0;
        float duration = 0.5f;  // Adjust for desired smoothness
        Vector3 startingPosition = transform.position;

        while (elapsedTime < duration)
        {
            transform.position = Vector3.Lerp(startingPosition, _originalPosition, elapsedTime / duration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Ensure the object ends exactly at the original position
        transform.position = _originalPosition;
    }
    public void backtodefultpostion()
    {
        transform.position = _originalPosition;
    }

/*

    // Test
    public async Task<bool> MockClaimNFT(int tokenAmount = 1)
    {
        Debug.Log($"[Mock] Amount to claim: {tokenAmount}");

        // Simulate switching network
        await Task.Delay(500);  // Simulate delay
        Debug.Log("[Mock] Switched network.");

        // Fake claim logic
        try
        {
            //ShowLoadingScreen(true, "[Mock] Sending Purchase Request...");

            await Task.Delay(1000); // Simulate processing delay

            if (tokenAmount <= 0)
            {
                Debug.LogWarning("[Mock] Invalid token amount.");
                return false;
            }

            bool isSuccess = UnityEngine.Random.value > 0.2f; // 80% chance of success

            if (!isSuccess)
            {
                Debug.Log("[Mock] Claim failed due to simulated error.");
                return false;
            }

            Debug.Log("[Mock] Claim succeeded!");
            return true;
        }
        catch (Exception e)
        {
            Debug.LogError("[Mock] Unexpected error: " + e);
            return false;
        }
        finally
        {
            //ShowLoadingScreen(false, "");
            Debug.Log("[Mock] Refreshed balance.");
        }
    }*/

}
