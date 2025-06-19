# 🤖 AI DevOps Proof of Concept

Deze repo demonstreert hoe een GitHub Action GPT-4o gebruikt om automatisch een bugfix-suggestie te doen voor een faillerende test.

## 🌐 Setup

1. Zorg voor een Azure OpenAI deployment met `gpt-4o` of `gpt-4`.
2. Voeg in GitHub repository settings → Secrets:
   - `OPENAI_API_KEY`: jouw Azure OpenAI key

3. Pas `OPENAI_ENDPOINT` en `DEPLOYMENT_NAME` aan in `.github/workflows/ai-bugfix.yml`.

## ▶️ Uitvoeren

Ga naar de tab **Actions** en run handmatig de workflow `🧠 AI Bugfix Suggestie`.  
De logs tonen de bug-analyse en voorstel voor fix van GPT-4o.

## Voorbeeld output

```diff
public decimal CalculateTotal(decimal amount, bool hasDiscount)
{
-    return amount;
+    return hasDiscount ? amount * 0.9m : amount;
}
```

## 📦 Stack

- C#/.NET fictieve service
- GitHub Actions
- Azure OpenAI (GPT-4o)
- Workflow op basis van base64 input en REST-API call
